using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLibrary;
using System.Web.Services;

namespace Services
{
    public class EvaluarProyectosImpl : IEvaluarProyectos
    {
        [WebMethod]
        public List<Proyecto> getProjectsById(int id)
        {
            List<Proyecto> listProjects = new List<Proyecto>();
            try
            {
                ProyectosDAO proyectosDAO = new ProyectosDAO();
                listProjects = proyectosDAO.getByIdProject(id);
            }catch(Exception ex)
            {
                throw ex;
            }
            return listProjects;
        }
    }
}
