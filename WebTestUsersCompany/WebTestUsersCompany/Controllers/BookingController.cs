using Microsoft.AspNetCore.Mvc;
using WebTestUsersCompany.Data;
using WebTestUsersCompany.ViewModels;

namespace WebTestUsersCompany.Controllers
{
    public class BookingController : Controller
    {
        //==============================================DATABASE===========================================
        private readonly AppDbContext _context;

        public BookingController(AppDbContext context)
        {
            _context = context;
        }
        //==============================================END DATABASE===========================================

        //==============================================DEFAULT PAGE===========================================
        public IActionResult Index()
        {
            return View(_context.RoomBookings.ToList());
        }
        //==============================================END DEFAULT PAGE===========================================

        //==============================================CREATE===========================================
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RoomBookingViewModel RoomBooking)
        {
            if (ModelState.IsValid)
            {
                _context.RoomBookings.Add(RoomBooking);
                _context.SaveChanges();
                // Menyimpan pesan di TempData setelah sukses
                TempData["success"] = "Room booking berhasil dibuat!";
                return RedirectToAction("Index");
            }
            return View(RoomBooking);
        }
        //==============================================END CREATE===========================================

        //==============================================UPDATE===========================================
        [HttpGet]
        public IActionResult Update(int Id)
        {
            var employee = _context.RoomBookings.Find(Id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Update(RoomBookingViewModel RoomBooking)
        {
            if (ModelState.IsValid)
            {
                _context.RoomBookings.Update(RoomBooking);
                _context.SaveChanges();
                // Menyimpan pesan di TempData setelah sukses
                TempData["success"] = "Room booking berhasil diperbarui!";
                return RedirectToAction(nameof(Index));
            }
            return View(RoomBooking);
        }
        //==============================================END UPDATE===========================================

        //==============================================DELETE===========================================
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var RoomBooking = _context.RoomBookings.Find(Id);
            if (RoomBooking != null)
            {
                _context.RoomBookings.Remove(RoomBooking);
                _context.SaveChanges();
                // Menyimpan pesan di TempData setelah sukses
                TempData["success"] = "Room booking berhasil dihapus!";
            }
            return RedirectToAction("Index");
        }
        //==============================================END DELETE===========================================
    }
}
