using Lection.Models;
using Lection.Services;
using Lection.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Lection.Controllers
{/*
 Создайте форму для регистрации пользователей. Проверяйте валидность данных, введенных пользователем, в контроллере с помощью ModelState.IsValid.
 
1) Создайте модель «User», которая будет представлять пользователя со свойствами, такими как: Id, Username, Email, Password и т.д.+
 
2) Создайте контроллер «UserController», который будет отвечать за обработку запросов, связанных с пользователями.+
 
3) Добавьте действие для отображения формы регистрации (Register) и действие для обработки отправленной формы (RegisterPost).
 
4) В методе действия RegisterPost контроллера UserController проверьте валидность данных, введенных пользователем, +
    с использованием атрибутов валидации: [Range] и [Required]. 
    Если данные неверны, отобразите сообщение об ошибке. Если данные верны – отобразите сообщение об успешной регистрации.
 
 */
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        // basic url: /User/Index
        [HttpGet]
        public ActionResult Index()
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }

        // User/Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // User/Register for POST request
        [HttpPost]
        public IActionResult Register(UserView model)
        {
            if (ModelState.IsValid)
            {
                var newUser = new User
                {
                    Username = model.Username,
                    Email = model.Email,
                    Age = model.Age,
                    Password = model.Password 
                };

                _userService.Register(newUser);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
