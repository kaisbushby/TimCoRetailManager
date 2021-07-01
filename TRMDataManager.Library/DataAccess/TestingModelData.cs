using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDataManager.Library.Internal.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public class TestingModelData
    {
        // TODO: Add an Interface for Dependency Injection use
        public List<TestingModel> GetTestingBlogs()
        {
            SqlDataAccess sql = new SqlDataAccess();

            List<TestingModel> output = sql.LoadData<TestingModel, dynamic>("dbo.TestingModel", null, "DeskMiniMSSQL");

            return output;
        }
    }
}
