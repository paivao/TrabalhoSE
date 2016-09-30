using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoSE.Filters;
using TrabalhoSE.Models;

namespace TrabalhoSE.Controllers
{
    [AuthorizeIPAddress]
    public class ArduinoController : Controller
    {
        // GET: Arduino
        public ActionResult Index()
        {
            return View();
        }

        // GET: Arduino/Sensor?temp=...
        public ActionResult Sensor(float? temp, float? hum, float? tension)
        {
            SensorData sensors = new SensorData { Temperature = temp, Humidity = hum, Power = tension, Time = DateTime.Now };
            (new ArduinoContext()).SensorData.Add(sensors);
            return new HttpStatusCodeResult(200);
            //return View();
        }
    }
}
