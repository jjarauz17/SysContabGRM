namespace HaciendaGT
{
    using Entities;
    using System.Collections.Generic;
    using System.Data;
    using static HaciendaGT.XmlFormatoComun;
    using static HaciendaGT.XmlFormatoFactura;

    public class CrearXmlFactura
    {
        
        public GTDocumento FacturaXml(FacturaElectronicaGT Header, DataTable Detalle)
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

            Frases frases = new Frases();
            frases.Frase = new List<Frase>{ new Frase { CodigoEscenario = Header.CodigoEscenario, TipoFrase = Header.TipoFrase } };

            TotalImpuestos TotalImpuestos = new TotalImpuestos
            {
                TotalImpuesto = new TotalImpuesto { NombreCorto = "IVA", TotalMontoImpuesto = Header.TotalMontoImpuesto.ToString() },
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
                    Impuesto = new Impuesto {
                        NombreCorto = "IVA",
                        CodigoUnidadGravable = "1",
                        MontoGravable = Detalle.Rows[i]["Gravable"].ToString(),
                        MontoImpuesto = Detalle.Rows[i]["Impuesto"].ToString(),
                    }
                };

                item.Add(new Item
                {
                    BienOServicio = Detalle.Rows[i]["Tipo"].ToString().Equals("P") ? "B" : "S",
                    Cantidad = Detalle.Rows[i]["Cantidad"].ToString(),
                    NumeroLinea = (i+1).ToString(),
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
                Item= item,
            };

            //Cuando la factura es de credito se agrega el complemento.
            Abono abono = new Abono
            {
                NumeroAbono = "1",
                FechaVencimiento = Header.Vencimiento,
                MontoAbono = Header.GranTotal.ToString(),
            };

            AbonosFacturaCambiaria abonoFC = new AbonosFacturaCambiaria
            {
                Cfc = "http://www.sat.gob.gt/dte/fel/CompCambiaria/0.1.0",
                Version = "1",
                SchemaLocation = Header.SchemaLocation,
                Abono = abono,
            };

            Complemento complemento = new Complemento
            {
                IDComplemento = "Cambiaria",
                NombreComplemento = "Cambiaria",
                URIComplemento = "http://www.sat.gob.gt/fel/cambiaria.xsd",
                AbonosFacturaCambiaria = abonoFC,
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
                Frases = frases,
                Items = items,
                Totales = totales,
                Complementos = complementos
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
                Adenda = new Adenda
                {
                    Codigo_cliente = Header.Codigo_cliente,
                    Observaciones = Header.Observaciones,
                    Lugar = Header.Lugar,
                    Vendedor = Header.Vendedor,
                    Forma_pago = Header.Forma_pago,
                    Vencimiento = Header.Vencimiento,
                    TCambio = Header.TCambio,
                    
                }
            };
           
            return new GTDocumento
            {
                SAT = sat,
            };
        }                        
    }
}
