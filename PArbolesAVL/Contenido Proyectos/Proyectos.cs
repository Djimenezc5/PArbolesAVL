using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PArbolesAVL.Contenido_Arboles;

namespace PArbolesAVL.Contenido_Proyectos
{
    class Proyectos : Comparador
    {
        public int prioridadproyecto { get; set; }
        public String departamentoProyecto { get; set; }
        public String nombreProyecto { get; set; }
        public double montoProyecto { get; set; }

        public Proyectos() 
        {
        
        }
        public Proyectos(int prioPro, String depPro, String nomPro, double montPro)
        {
            this.prioridadproyecto = prioPro;
            this.departamentoProyecto = depPro;
            this.nombreProyecto = nomPro;
            this.montoProyecto = montPro;
        }


        public bool igualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorQue(object q)
        {
            Proyectos Paux = (Proyectos)q;
            bool aux = false;
            if (prioridadproyecto <= Paux.prioridadproyecto)
            {
                if (departamentoProyecto == "Chiquimula" || departamentoProyecto == "Zacapa" || departamentoProyecto == "El Progreso" || departamentoProyecto == "Alta Verapaz" || departamentoProyecto == "Baja Verapaz" || departamentoProyecto == "Guatemala" || departamentoProyecto.CompareTo(Paux.departamentoProyecto) > 0 || departamentoProyecto.CompareTo(Paux.departamentoProyecto) < 0) 
                {
                    if (nombreProyecto.CompareTo(Paux.nombreProyecto) < 0 || nombreProyecto.CompareTo(Paux.nombreProyecto) > 0)
                    {
                        aux = true;
                    }
                    else
                    {
                        aux = false;
                    }
                }
                else
                {
                    aux = false;
                }

            }
            else
            {
                aux = false;
            }

            return aux;
        }

        public bool menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool menorQue(object q)
        {
            Proyectos Paux = (Proyectos)q;
            bool aux = false;
            if (prioridadproyecto >= Paux.prioridadproyecto)
            {
                if (departamentoProyecto.CompareTo(Paux.departamentoProyecto) >= 0 || departamentoProyecto.CompareTo(Paux.departamentoProyecto) <= 0)
                {
                       if (nombreProyecto.CompareTo(Paux.nombreProyecto) < 0 || nombreProyecto.CompareTo(Paux.nombreProyecto) > 0)
                        {
                            aux = true;
                        }
                        else
                        {
                            aux = false;
                        }
                }
                else
                {
                    aux = false;
                }
            }
            else
            {
                aux = false;
            }

            return aux;
        }

        public override string ToString()
        {
            return "(" + prioridadproyecto + " --> " + nombreProyecto + " --> " + departamentoProyecto + " --> " + montoProyecto + ")";
        }
    }
}
