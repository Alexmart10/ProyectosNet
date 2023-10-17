using CapaEntidades;
using CapaLogica.ManejadorResult;
using System.Data;

namespace WebAppAdmMvc.Servicios.Contrato
{
    public interface ICatalogo
    {
        Task <List<tblCatalogo>> GetCatalogoLista();

    }
}
