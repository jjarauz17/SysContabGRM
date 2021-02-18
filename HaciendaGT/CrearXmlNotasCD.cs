using System;
using Entities;
using System.Data;
using System.Collections.Generic;
using static HaciendaGT.XmlFormatoComun;
using static HaciendaGT.XmlFormatoNotaCredito;

namespace HaciendaGT
{
   public class CrearXmlNotasCD
    {
        public GTDocumento NotaCDXml(FacturaElectronicaGT Header,
            DataTable Detalle,
            ResponseApi Api,
            string Motivo)
        {

            DireccionEmisor direccionEmisor = new DireccionEmisor
            {
                Direccion = Header.DireccionEmisor,
                CodigoPostal = Header.CodigoPostalEmisor,
                Municipio = Header.MunicipioEmisor,
                Departamento = Header.DepartamentoEmisor,
                Pais = Header.PaisEmisor,
            };

            DireccionReceptor direccionReceptor = new DireccionReceptor
            {
                Direccion = Header.DireccionReceptor,
                CodigoPostal = Header.CodigoPostalReceptor,
                Municipio = Header.MunicipioReceptor,
                Departamento = Header.DepartamentoReceptor,
                Pais = Header.PaisReceptor,
            };

            Totales totales = new Totales
            {
                TotalImpuestos = new TotalImpuestos
                {
                    TotalImpuesto = new TotalImpuesto { NombreCorto = "IVA", TotalMontoImpuesto = Header.TotalMontoImpuesto.ToString() },
                },
                GranTotal = Header.GranTotal.ToString(),
            };

            List<Item> item = new List<Item>();
            List<Impuesto> impuesto = new List<Impuesto>();

            for (int i = 0; i <= Detalle.Rows.Count - 1; i++)
            {
                Impuestos impuestos = new Impuestos
                {
                    Impuesto = new Impuesto
                    {
                        NombreCorto = "IVA",
                        CodigoUnidadGravable = Convert.ToDouble(Detalle.Rows[i]["Impuesto"]) == 0.00 ? "2" : "1",
                        MontoGravable = Detalle.Rows[i]["Gravable"].ToString(),
                        MontoImpuesto = Detalle.Rows[i]["Impuesto"].ToString(),
                    }
                };

                item.Add(new Item
                {
                    BienOServicio = Detalle.Rows[i]["Tipo"].ToString().Equals("P") ? "B" : "S",
                    Cantidad = Detalle.Rows[i]["Cantidad"].ToString(),
                    NumeroLinea = (i + 1).ToString(),
                    UnidadMedida = Detalle.Rows[i]["Unidad"].ToString(),
                    Descripcion = Detalle.Rows[i]["Descripcion"].ToString(),
                    PrecioUnitario = Detalle.Rows[i]["Unitario"].ToString(),
                    Precio = Detalle.Rows[i]["Precio"].ToString(),
                    Descuento = Detalle.Rows[i]["Descuento"].ToString(),
                    Impuesto = impuestos,
                    Total = Detalle.Rows[i]["Total"].ToString(),
                });
            }

            Items items = new Items
            {
                Item = item,
            };

            ReferenciasNota referencia = new ReferenciasNota
            {
                Cno = "http://www.sat.gob.gt/face2/ComplementoReferenciaNota/0.1.0",
                FechaEmisionDocumentoOrigen = Api.fecha.Substring(0, 10),
                MotivoAjuste = Motivo,
                NumeroAutorizacionDocumentoOrigen = Api.uuid,
                NumeroDocumentoOrigen = Api.numero,
                SerieDocumentoOrigen = Api.serie,
                Version = "0.0",
                SchemaLocation = Header.SchemaLocation
            };

            Complemento complemento = new Complemento
            {
                IDComplemento = "Notas",
                NombreComplemento = "Notas",
                URIComplemento = "http://www.sat.gob.gt/fel/notas.xsd",
                ReferenciasNota = referencia
            };

            Complementos complementos = new Complementos
            {
                Complemento = complemento
            };

            DatosEmision datosEmision = new DatosEmision
            {
                ID = "DatosEmision",
                DatosGenerales = new DatosGenerales
                {
                    CodigoMoneda = Header.CodigoMoneda,
                    FechaHoraEmision = Header.FechaHoraEmision,
                    Tipo = Header.Tipo,
                },
                Emisor = new Emisor
                {
                    AfiliacionIVA = Header.AfiliacionIVA,
                    CodigoEstablecimiento = Header.CodigoEstablecimiento,
                    CorreoEmisor = Header.CorreoEmisor,
                    NITEmisor = Header.NITEmisor,
                    NombreComercial = Header.NombreComercial,
                    NombreEmisor = Header.NombreEmisor,
                    DireccionEmisor = direccionEmisor,
                },
                Receptor = new Receptor
                {
                    CorreoReceptor = Header.CorreoReceptor,
                    IDReceptor = Header.IDReceptor,
                    NombreReceptor = Header.NombreReceptor,
                    DireccionReceptor = direccionReceptor,
                },
                Items = items,
                Totales = totales,
                Complementos = complementos,
            };

            DTE dte = new DTE
            {
                ID = "DatosCertificados",
                DatosEmision = datosEmision,
            };

            SAT sat = new SAT
            {
                ClaseDocumento = "dte",
                DTE = dte,
            };

            return new GTDocumento
            {
                SAT = sat,
            };
        }

    }
}
