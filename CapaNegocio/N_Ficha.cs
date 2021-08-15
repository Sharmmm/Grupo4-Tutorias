using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class N_Ficha
    {
        D_Ficha data = new D_Ficha();
        E_Ficha entities = new E_Ficha();

        public DataTable ListingFichas()
        {
            return data.ListFichas();
        }
        public DataTable SearchingFichas(string search)
        {
            entities.Search = search;
            return data.SearchFichas(entities);
        }

        public void CreatingFicha(E_Ficha product)
        {
            data.CreateFicha(product);
        }

        public void UpdatingFicha(E_Ficha product)
        {
            data.UpdateFicha(product);
        }

        public void DeletingFicha(int Id)
        {
            data.DeleteFicha(Id);
        }
    }
}
