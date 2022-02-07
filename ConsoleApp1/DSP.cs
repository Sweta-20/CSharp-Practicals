using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BussinessLogicLayer
    {
        private readonly IRepositoryLayer RL;
        public BussinessLogicLayer(IRepositoryLayer repositorylayer)
        {
            RL = repositorylayer;
        }
        public void save(object details)
        {
            RL.save(details);
        }
    }
    public interface IRepositoryLayer
    {
        void save(object details);
    }
    public class DataAccessLayer :IRepositoryLayer
    {
        public void save(object details)
        {

        }
    }
    //Without DSP
    //public class BussinessLogicLayer
    //{
    //    private readonly IRepositoryLayer RL;
    //    public BussinessLogicLayer()
    //    {
    //     DataAccessLayer DAL = new DataAccessLayer();
    //    }
    //    public void save(object details)
    //    {
    //        DAL.save(details);
    //    }
    //}
    //public class DataAccessLayer : IRepositoryLayer
    //{
    //    public void save(object details)
    //    {

    //    }
    //}
}
