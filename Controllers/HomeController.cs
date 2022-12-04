using FootBallMatchs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootBallMatchs.Models;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FootBallMatchs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult AddMatch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMatch(int MatchID, String TeamName1,String TeamName2,String Status,String WinningTeam,int Points)
        {

            //if (ModelState.IsValid)
            //    {
            //        context.FootBallLeague.Add(m);
            //       context.SaveChanges();
            //        return RedirectToAction("Index");
            //    }
            //    return View("AddMatch");
            String constring = "server=.;database=Projects;integrated security=true";
            SqlConnection sqlcon = new SqlConnection(constring);

            sqlcon.Open();
            string query = "Matches";
            SqlCommand COM = new SqlCommand(query, sqlcon); ;
            COM.CommandType = System.Data.CommandType.StoredProcedure;
            COM.Parameters.AddWithValue("@MatchID", Convert.ToInt32(MatchID));
            COM.Parameters.AddWithValue("@TeamName1", Convert.ToString(TeamName1));
            COM.Parameters.AddWithValue("@TeamName2", TeamName2);
            COM.Parameters.AddWithValue("@Status", Status);
            COM.Parameters.AddWithValue("@WinningTeam", WinningTeam);
            COM.Parameters.AddWithValue("@Points", Convert.ToInt32(Points));
            COM.ExecuteNonQuery();
            sqlcon.Close();
            return View("Index");
        }
        public ActionResult Index() 
        {
            return View();
        }
        public ActionResult Validation()
        {
            return View("");
        }
        MyDbContext context = new MyDbContext();
        
    }
}