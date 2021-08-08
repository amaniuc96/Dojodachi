using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;


namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        Dojodachi panda = new Dojodachi();
        Random rand = new Random();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            TempData["GameStatus"] = "Playing";

            if( HttpContext.Session.GetInt32("Happiness") == null)
            {
                HttpContext.Session.SetInt32("Happiness" , 20);
            }

            if( HttpContext.Session.GetInt32("Fullness") == null)
            {
                HttpContext.Session.SetInt32("Fullness" , 20);
            }

            if( HttpContext.Session.GetInt32("Energy") == null)
            {
                HttpContext.Session.SetInt32("Energy" , 50);
            }

            if( HttpContext.Session.GetInt32("Meal") == null) 
            {
                HttpContext.Session.SetInt32( "Meal", 3);
            }
            if ( HttpContext.Session.GetString("ImgUrl") == null)
            {
                TempData["Message"] = "Pandadachi Is Waiting For You...Let Us Start";
                HttpContext.Session.SetString("ImgUrl" , "~/img/default.jpg");
            }

            // lose condition
            if( HttpContext.Session.GetInt32("Energy") <= 0 || HttpContext.Session.GetInt32("Happiness") <= 0)
            {
                TempData["GameStatus"] = "Over";
                TempData["Message"] = "Your Pandadachi has passed away :( ! ";
                Lose();
            }

            // win condition
            if( HttpContext.Session.GetInt32("Energy") >= 100 && HttpContext.Session.GetInt32("Fullness") >= 100 && HttpContext.Session.GetInt32("Happiness") >= 100)
            {
                TempData["GameStatus"] = "Over";
                TempData["Message"] = "CONGRATULATIONS :) You Won ! Get your Prize!";
                Win();
            }

            TempData["Happiness"] = HttpContext.Session.GetInt32("Happiness");
            TempData["Fullness"] = HttpContext.Session.GetInt32("Fullness");
            TempData["Energy"] = HttpContext.Session.GetInt32("Energy");
            TempData["Meal"] = HttpContext.Session.GetInt32("Meal");
            // set image 
            ViewBag.ImgUrl = HttpContext.Session.GetString("ImgUrl");

            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            Console.WriteLine("FROM FEED Mehtod");

            if( HttpContext.Session.GetInt32("Meal") <= 0) 
            {
                TempData["Message"] = "You DON'T Have Enough Meals!";
                Sad();
            } 
            else
            {
                HttpContext.Session.SetInt32("Meal" , (int)HttpContext.Session.GetInt32("Meal") - 1);
                int chance = rand.Next(0, 4);
                if(chance == 0)
                {
                    TempData["Message"] = "Pandadachi DIDN'T Like It's Food";
                    Angry();
                }
                else
                {
                    int? full =rand.Next(5,11);
                    HttpContext.Session.SetInt32("Fullness" , (int)HttpContext.Session.GetInt32("Fullness") + (int)full);
                    TempData["Message"] = $"You Feed Pandadachi and cost you 1 Meal , Fullness +{full} ";
                    Eat();
                    Console.WriteLine(TempData["Message"]);
                }
            }
            
            return RedirectToAction("Index");

        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            if( HttpContext.Session.GetInt32("Energy") == 0 )
            {
                TempData["Message"] = "You CAN'T Play With Pandadachi Right Now.. Because It's Tired.";
                Tired();
            }
            int chance = rand.Next(0, 4);
            if(chance == 0)
            {
                TempData["Message"] = "Pandadachi DOESN'T Like The Game . Try Another One!";
                Angry();
            }
            else
            {
                int? happy =rand.Next(5,11);
                HttpContext.Session.SetInt32("Happiness" , (int)HttpContext.Session.GetInt32("Happiness") + (int)happy);
                TempData["Message"] = $"Your Pandadachi's Happiness +{happy} And Become : {HttpContext.Session.GetInt32("Happiness")} ";
                Joy();
                Console.WriteLine(TempData["Message"]);
            }
            HttpContext.Session.SetInt32("Energy" , (int)HttpContext.Session.GetInt32("Energy") - 5);
            return RedirectToAction("Index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            if( HttpContext.Session.GetInt32("Energy") == 0 )
            {
                TempData["Message"] = "Pandadachi CAN'T Go To The Work Right Now!..Because It's Tired!.";
                Tired();
                
            }
            else
            {
                int? meal =rand.Next(1,4);
                int energy = 5;
                HttpContext.Session.SetInt32("Energy" , (int)HttpContext.Session.GetInt32("Energy") - energy);
                HttpContext.Session.SetInt32("Meal" , (int)HttpContext.Session.GetInt32("Meal") + (int)meal);
                TempData["Message"] = $"Pandadachi Went To Work, Energy -{energy} , Meals -{meal}";
                Perform();
                Console.WriteLine(TempData["Message"]);
            }
            return RedirectToAction("Index");

        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            int fifteen=15;
            int five=5;
            HttpContext.Session.SetInt32("Energy" , (int)HttpContext.Session.GetInt32("Energy") + fifteen);
            HttpContext.Session.SetInt32("Happiness" , (int)HttpContext.Session.GetInt32("Happiness") - five);
            HttpContext.Session.SetInt32("Fullness" , (int)HttpContext.Session.GetInt32("Fullness") - five);
            TempData["Message"] = $"Pandadachi Went To Sleep, Energy +{fifteen}. Happiness And Fullness -{five}";
            Nap();
            Console.WriteLine(TempData["Message"]);
            return RedirectToAction("Index");
        }
        public void Angry()
        {
            var angry = new ArrayList();
            HttpContext.Session.SetString("ImgUrl1" , "~/img/angry/angry1.jpg");
            HttpContext.Session.SetString("ImgUrl2" , "~/img/angry/angry2.jpeg");
            HttpContext.Session.SetString("ImgUrl3" , "~/img/angry/angry3.jpg");
            HttpContext.Session.SetString("ImgUrl4" , "~/img/angry/angry4.jpg");
            HttpContext.Session.SetString("ImgUrl5" , "~/img/angry/angry5.png");
            HttpContext.Session.SetString("ImgUrl6" , "~/img/angry/angry6.jpg");
            HttpContext.Session.SetString("ImgUrl7" , "~/img/angry/angry7.gif");
            HttpContext.Session.SetString("ImgUrl8" , "~/img/angry/angry8.jpg");
            angry.Add(HttpContext.Session.GetString("ImgUrl1"));
            angry.Add(HttpContext.Session.GetString("ImgUrl2"));
            angry.Add(HttpContext.Session.GetString("ImgUrl3"));
            angry.Add(HttpContext.Session.GetString("ImgUrl4"));
            angry.Add(HttpContext.Session.GetString("ImgUrl5"));
            angry.Add(HttpContext.Session.GetString("ImgUrl6"));
            angry.Add(HttpContext.Session.GetString("ImgUrl7"));
            angry.Add(HttpContext.Session.GetString("ImgUrl8"));
            Random random = new Random();
            for(var i=0;i<1;i++){
                int randidx = random.Next(0,angry.Count); 
                HttpContext.Session.SetString("ImgUrl" , $"{angry[randidx]}");
            }
        }
        public void Sad()
        {
            var sad = new ArrayList();
                    HttpContext.Session.SetString("ImgUrl1" , "~/img/sad/sad1.jpg");
                    HttpContext.Session.SetString("ImgUrl2" , "~/img/sad/sad2.png");
                    HttpContext.Session.SetString("ImgUrl3" , "~/img/sad/sad3.png");
                    HttpContext.Session.SetString("ImgUrl4" , "~/img/sad/sad4.jpg");
                    HttpContext.Session.SetString("ImgUrl5" , "~/img/sad/sad5.jpg");
                    HttpContext.Session.SetString("ImgUrl6" , "~/img/sad/sad6.jpg");
                    HttpContext.Session.SetString("ImgUrl7" , "~/img/sad/sad7.png");
                    HttpContext.Session.SetString("ImgUrl8" , "~/img/sad/sad8.gif");
                    sad.Add(HttpContext.Session.GetString("ImgUrl1"));
                    sad.Add(HttpContext.Session.GetString("ImgUrl2"));
                    sad.Add(HttpContext.Session.GetString("ImgUrl3"));
                    sad.Add(HttpContext.Session.GetString("ImgUrl4"));
                    sad.Add(HttpContext.Session.GetString("ImgUrl5"));
                    sad.Add(HttpContext.Session.GetString("ImgUrl6"));
                    sad.Add(HttpContext.Session.GetString("ImgUrl7"));
                    sad.Add(HttpContext.Session.GetString("ImgUrl8"));
                    Random random = new Random();
                    for(var i=0;i<1;i++){
                        int randidx = random.Next(0,sad.Count); 
                        HttpContext.Session.SetString("ImgUrl" , $"{sad[randidx]}");
                    }
        }
        public void Eat()
        {
            var eat = new ArrayList();
            HttpContext.Session.SetString("ImgUrl1" , "~/img/eat/eat1.jpeg");
            HttpContext.Session.SetString("ImgUrl2" , "~/img/eat/eat2.jpeg");
            HttpContext.Session.SetString("ImgUrl3" , "~/img/eat/eat3.jpeg");
            HttpContext.Session.SetString("ImgUrl4" , "~/img/eat/eat4.jpeg");
            HttpContext.Session.SetString("ImgUrl5" , "~/img/eat/eat5.jpeg");
            HttpContext.Session.SetString("ImgUrl6" , "~/img/eat/eat6.jpg");
            HttpContext.Session.SetString("ImgUrl7" , "~/img/eat/eat7.jpg");
            HttpContext.Session.SetString("ImgUrl8" , "~/img/eat/eat8.png");
            eat.Add(HttpContext.Session.GetString("ImgUrl1"));
            eat.Add(HttpContext.Session.GetString("ImgUrl2"));
            eat.Add(HttpContext.Session.GetString("ImgUrl3"));
            eat.Add(HttpContext.Session.GetString("ImgUrl4"));
            eat.Add(HttpContext.Session.GetString("ImgUrl5"));
            eat.Add(HttpContext.Session.GetString("ImgUrl6"));
            eat.Add(HttpContext.Session.GetString("ImgUrl7"));
            eat.Add(HttpContext.Session.GetString("ImgUrl8"));
            Random random = new Random();
            for(var i=0;i<1;i++){
                int randidx = random.Next(0,eat.Count); 
                HttpContext.Session.SetString("ImgUrl" , $"{eat[randidx]}");
            }
        }
        public void Lose()
        {
            var lose = new ArrayList();
            HttpContext.Session.SetString("ImgUrl1" , "~/img/lose/lose1.gif");
            HttpContext.Session.SetString("ImgUrl2" , "~/img/lose/lose2.jpg");
            HttpContext.Session.SetString("ImgUrl3" , "~/img/lose/lose3.png");
            lose.Add(HttpContext.Session.GetString("ImgUrl1"));
            lose.Add(HttpContext.Session.GetString("ImgUrl2"));
            lose.Add(HttpContext.Session.GetString("ImgUrl3"));
            Random random = new Random();
            for(var i=0;i<1;i++){
                int randidx = random.Next(0,lose.Count); 
                HttpContext.Session.SetString("ImgUrl" , $"{lose[randidx]}");
            }
        }
        public void Tired()
        {
            var tired = new ArrayList();
            HttpContext.Session.SetString("ImgUrl1" , "~/img/tired/tired1.jpg");
            HttpContext.Session.SetString("ImgUrl2" , "~/img/tired/tired2.png");
            HttpContext.Session.SetString("ImgUrl3" , "~/img/tired/tired3.jpg");
            HttpContext.Session.SetString("ImgUrl4" , "~/img/tired/tired4.jpg");
            HttpContext.Session.SetString("ImgUrl5" , "~/img/tired/tired5.jpg");
            HttpContext.Session.SetString("ImgUrl6" , "~/img/tired/tired6.jpg");
            HttpContext.Session.SetString("ImgUrl7" , "~/img/tired/tired7.png");
            HttpContext.Session.SetString("ImgUrl8" , "~/img/tired/tired8.png");
            HttpContext.Session.SetString("ImgUrl9" , "~/img/tired/tired9.jpg");
            tired.Add(HttpContext.Session.GetString("ImgUrl1"));
            tired.Add(HttpContext.Session.GetString("ImgUrl2"));
            tired.Add(HttpContext.Session.GetString("ImgUrl3"));
            tired.Add(HttpContext.Session.GetString("ImgUrl4"));
            tired.Add(HttpContext.Session.GetString("ImgUrl5"));
            tired.Add(HttpContext.Session.GetString("ImgUrl6"));
            tired.Add(HttpContext.Session.GetString("ImgUrl7"));
            tired.Add(HttpContext.Session.GetString("ImgUrl8"));
            tired.Add(HttpContext.Session.GetString("ImgUrl9"));
            Random random = new Random();
            for(var i=0;i<1;i++){
                int randidx = random.Next(0,tired.Count); 
                HttpContext.Session.SetString("ImgUrl" , $"{tired[randidx]}");
            }
        }
        public void Joy(){
            var joy = new ArrayList();
            HttpContext.Session.SetString("ImgUrl1" , "~/img/joy/joy1.jpg");
            HttpContext.Session.SetString("ImgUrl2" , "~/img/joy/joy2.jpeg");
            HttpContext.Session.SetString("ImgUrl3" , "~/img/joy/joy3.jpeg");
            HttpContext.Session.SetString("ImgUrl4" , "~/img/joy/joy4.jpg");
            HttpContext.Session.SetString("ImgUrl5" , "~/img/joy/joy5.png");
            HttpContext.Session.SetString("ImgUrl6" , "~/img/joy/joy6.png");
            HttpContext.Session.SetString("ImgUrl7" , "~/img/joy/joy7.png");
            HttpContext.Session.SetString("ImgUrl8" , "~/img/joy/joy8.jpg");
            joy.Add(HttpContext.Session.GetString("ImgUrl1"));
            joy.Add(HttpContext.Session.GetString("ImgUrl2"));
            joy.Add(HttpContext.Session.GetString("ImgUrl3"));
            joy.Add(HttpContext.Session.GetString("ImgUrl4"));
            joy.Add(HttpContext.Session.GetString("ImgUrl5"));
            joy.Add(HttpContext.Session.GetString("ImgUrl6"));
            joy.Add(HttpContext.Session.GetString("ImgUrl7"));
            joy.Add(HttpContext.Session.GetString("ImgUrl8"));
            Random random = new Random();
            for(var i=0;i<1;i++){
                int randidx = random.Next(0,joy.Count); 
                HttpContext.Session.SetString("ImgUrl" , $"{joy[randidx]}");
            }
        }
        public void Perform(){
            var perform = new ArrayList();
            HttpContext.Session.SetString("ImgUrl1" , "~/img/perform/perform1.jpg");
            HttpContext.Session.SetString("ImgUrl2" , "~/img/perform/perform2.jpeg");
            HttpContext.Session.SetString("ImgUrl3" , "~/img/perform/perform3.jpeg");
            HttpContext.Session.SetString("ImgUrl4" , "~/img/perform/perform4.jpg");
            HttpContext.Session.SetString("ImgUrl5" , "~/img/perform/perform5.jpeg");
            HttpContext.Session.SetString("ImgUrl6" , "~/img/perform/perform6.jpg");
            HttpContext.Session.SetString("ImgUrl7" , "~/img/perform/perform7.jpg");
            HttpContext.Session.SetString("ImgUrl8" , "~/img/perform/perform8.jpg");
            perform.Add(HttpContext.Session.GetString("ImgUrl1"));
            perform.Add(HttpContext.Session.GetString("ImgUrl2"));
            perform.Add(HttpContext.Session.GetString("ImgUrl3"));
            perform.Add(HttpContext.Session.GetString("ImgUrl4"));
            perform.Add(HttpContext.Session.GetString("ImgUrl5"));
            perform.Add(HttpContext.Session.GetString("ImgUrl6"));
            perform.Add(HttpContext.Session.GetString("ImgUrl7"));
            perform.Add(HttpContext.Session.GetString("ImgUrl8"));
            Random random = new Random();
            for(var i=0;i<1;i++){
                int randidx = random.Next(0,perform.Count); 
                HttpContext.Session.SetString("ImgUrl" , $"{perform[randidx]}");
            }
        }
        public void Nap(){
            var nap = new ArrayList();
            HttpContext.Session.SetString("ImgUrl1" , "~/img/nap/nap1.jpg");
            HttpContext.Session.SetString("ImgUrl2" , "~/img/nap/nap2.jpg");
            HttpContext.Session.SetString("ImgUrl3" , "~/img/nap/nap3.jpg");
            HttpContext.Session.SetString("ImgUrl4" , "~/img/nap/nap4.jpeg");
            HttpContext.Session.SetString("ImgUrl5" , "~/img/nap/nap5.jpg");
            HttpContext.Session.SetString("ImgUrl6" , "~/img/nap/nap6.jpg");
            HttpContext.Session.SetString("ImgUrl7" , "~/img/nap/nap7.jpg");
            HttpContext.Session.SetString("ImgUrl8" , "~/img/nap/nap8.jpg");
            nap.Add(HttpContext.Session.GetString("ImgUrl1"));
            nap.Add(HttpContext.Session.GetString("ImgUrl2"));
            nap.Add(HttpContext.Session.GetString("ImgUrl3"));
            nap.Add(HttpContext.Session.GetString("ImgUrl4"));
            nap.Add(HttpContext.Session.GetString("ImgUrl5"));
            nap.Add(HttpContext.Session.GetString("ImgUrl6"));
            nap.Add(HttpContext.Session.GetString("ImgUrl7"));
            nap.Add(HttpContext.Session.GetString("ImgUrl8"));
            Random random = new Random();
            for(var i=0;i<1;i++){
                int randidx = random.Next(0,nap.Count); 
                HttpContext.Session.SetString("ImgUrl" , $"{nap[randidx]}");
            }
        }
        public void Win(){
            var win = new ArrayList();
            HttpContext.Session.SetString("ImgUrl1" , "~/img/win/win1.jpg");
            HttpContext.Session.SetString("ImgUrl2" , "~/img/win/win2.jpg");
            HttpContext.Session.SetString("ImgUrl3" , "~/img/win/win3.png");
            HttpContext.Session.SetString("ImgUrl4" , "~/img/win/win4.jpg");
            HttpContext.Session.SetString("ImgUrl5" , "~/img/win/win5.jpg");
            win.Add(HttpContext.Session.GetString("ImgUrl1"));
            win.Add(HttpContext.Session.GetString("ImgUrl2"));
            win.Add(HttpContext.Session.GetString("ImgUrl3"));
            win.Add(HttpContext.Session.GetString("ImgUrl4"));
            win.Add(HttpContext.Session.GetString("ImgUrl5"));
            Random random = new Random();
            for(var i=0;i<1;i++){
                int randidx = random.Next(0,win.Count); 
                HttpContext.Session.SetString("ImgUrl" , $"{win[randidx]}");
            }
        }
        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
