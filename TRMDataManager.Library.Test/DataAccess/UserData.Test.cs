using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;
//using Microsoft.AspNet.Identity;

namespace TRMDataManager.Library.Test.DataAccess
{
    [TestFixture]
    public class UerDataTest
    {
        [Test]
        public void can_get_userID()
        {
            /*string id = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(id).First();*/
        }

        [Test]
        public void can_load_data_from_database()
        {


        }
    }
}
