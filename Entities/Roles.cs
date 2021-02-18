namespace Entities
{
    using System;
    public class Roles
    {
        int vID;

        public int ID
        {
            get
            {
                return vID;
            }
            set
            {
                vID = value;
            }
        }

        string vNombre;

        public string Nombre
        {
            get
            {
                return vNombre;
            }
            set
            {
                vNombre = value;
            }
        }

        string vDescripcion;

        public string Descripcion
        {
            get
            {
                return vDescripcion;
            }
            set
            {
                vDescripcion = value;
            }
        }

    }

}
