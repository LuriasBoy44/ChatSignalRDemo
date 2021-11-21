using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ChatRoomsProyect.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, String> Rooms = new Dictionary<int, string>() {

            { 1,"Salón 1"},
            { 2,"Salón 2"},
            { 3,"Salón 3"},
            { 4,"Salón 4"},
            { 5,"Salón 5"},
            { 6,"Salón 6"},
            { 7,"Salón 7"},
            { 8,"Salón 6"},
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
