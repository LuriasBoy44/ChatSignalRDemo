using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatRoomsProyect.Models;

namespace ChatRoomsProyect.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, String> Rooms = new Dictionary<int, string>() {

            { 1,"Sala 1"},
            { 2,"Sala Dos"},
            { 3,"Sala III"},
            { 4,"sAlA kUaTr0"},
            { 5,"Salon 5" }
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
