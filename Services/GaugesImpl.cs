using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;

namespace ServicesLibrary
{
    public class GaugesImpl : IGauges
    {
        public bool createGaugesByIdProject(Gauges gauges)
        {
            bool responseService = false;
            try
            {
                GaugesDAO gaugesDAO = new GaugesDAO();
                gauges.observacion_indicador = gauges.observacion_indicador == null ? gauges.observacion_indicador = "sin observacion" : gauges.observacion_indicador;
                responseService = gaugesDAO.createGaugeByIdProject(gauges);
            }
            catch(Exception ex)
            {
                responseService = false;
                throw ex;
            }           
            return responseService;
        }
    }
}
