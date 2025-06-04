using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fvm.Models;
using fvm.DAL;

namespace fvm.Controllers
{
    public class EquipmentController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Equipment/
        public ActionResult Index(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString)
                                            || s.EquipmentDOT.Contains(searchString)
                                            || s.EquipmentDOTDateText.Contains(searchString)
                                            || s.EquipmentNote.Contains(searchString)
                                            || s.EquipmentText.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderByDescending(s => s.EquipmentDOT).ThenByDescending(s => s.EquipmentDown).ThenBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                //case "equipmentdesignator_desc":
                //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                //    break;
                //case "contactschooldistrict":
                //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                //    break;
                //case "contactschooldistrict_desc":
                //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                //    break;
                //case "contactaddresscitytown":
                //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                //    break;
                //case "contactaddresscitytown_desc":
                //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                //    break;
            }
            return View(equipments);
        }

        public ActionResult Inactive(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentInactive != null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderByDescending(s => s.EquipmentDOT).ThenByDescending(s => s.EquipmentDown).ThenBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "equipmentdesignator_desc":
                    //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                    //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult Northport(string sortOrder, string searchString)
        {
            ViewBag.equipmentDOT = String.IsNullOrEmpty(sortOrder) ? "equipmentdotdate" : "";
          //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
          //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "Northport"
                                || s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString)
                                                        || s.EquipmentDOT.Contains(searchString)
                                                        || s.EquipmentDOTDateText.Contains(searchString)
                                                        || s.EquipmentNote.Contains(searchString)
                                                        || s.EquipmentText.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderByDescending(s => s.EquipmentDOT).ThenByDescending(s => s.EquipmentDown).ThenBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    case "equipmentdotdate":
                        equipments = equipments.OrderByDescending(s => s.EquipmentDOT).ThenBy(s => s.EquipmentDown).ThenBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                        break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult Down(string sortOrder, string searchString)
        {
            ViewBag.equipmentDOT = String.IsNullOrEmpty(sortOrder) ? "equipmentdotdate" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentDOT != null
                                || s.EquipmentDown != null
                                || s.EquipmentDOTDateText != null
                                && s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderByDescending(s => s.EquipmentDOT).ThenByDescending(s => s.EquipmentDown).ThenBy(s => s.EquipmentDOTDateText).ThenBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                case "equipmentdotdate":
                    equipments = equipments.OrderByDescending(s => s.EquipmentDOT).ThenByDescending(s => s.EquipmentDOTDateText).ThenByDescending(s => s.EquipmentDown).ThenByDescending(s => s.EquipmentDOTDateText).ThenBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult Radio(string sortOrder, string searchString)
        {
            ViewBag.equipmentradio = String.IsNullOrEmpty(sortOrder) ? "equipmentradio" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "Northport"
                                && s.EquipmentRadioReported != null
                                && s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                case "equipmentradio":
                    equipments = equipments.OrderByDescending(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult DOT(string sortOrder, string searchString)
        {
            ViewBag.equipmentDOT = String.IsNullOrEmpty(sortOrder) ? "equipmentdotdate" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "Northport"
                                && s.EquipmentDOT != null
                                //|| s.EquipmentDown != null
                                || s.EquipmentDOTDateText != null
                                && s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderByDescending(s => s.EquipmentDOT).ThenBy(s => s.EquipmentDOTDateText).ThenBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                //case "equipmentdotdate":
                //    equipments = equipments.OrderByDescending(s => s.EquipmentDOT).ThenByDescending(s => s.EquipmentDown).ThenByDescending(s => s.EquipmentDOTDateText).ThenBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult Bohemia(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "Bohemia"
                                || s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "equipmentdesignator_desc":
                    //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                    //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult CentralIslip(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "Central Islip"
                                || s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "equipmentdesignator_desc":
                    //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                    //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult Copiague(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "Copiague"
                                || s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "equipmentdesignator_desc":
                    //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                    //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult Coram(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "Coram"
                                || s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "equipmentdesignator_desc":
                    //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                    //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult Oceanside(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "Oceanside"
                                || s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "equipmentdesignator_desc":
                    //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                    //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        public ActionResult WilliamFloyd(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             where s.EquipmentLocation == "William Floyd"
                                || s.EquipmentInactive == null
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "equipmentdesignator_desc":
                    //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                    //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        // GET: /Equipment/
        public ActionResult Menu(string sortOrder, string searchString)
        {
            //ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var equipments = from s in db.Equipments
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                equipments = equipments.Where(s => s.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    equipments = equipments.OrderBy(s => s.EquipmentType).ThenBy(s => s.EquipmentDesignator);
                    break;
                    //case "equipmentdesignator_desc":
                    //    equipments = equipments.OrderByDescending(s => s.EquipmentDesignator);
                    //    break;
                    //case "contactschooldistrict":
                    //    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactschooldistrict_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    //    break;
                    //case "contactaddresscitytown":
                    //    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    //    break;
                    //case "contactaddresscitytown_desc":
                    //    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    //    break;
            }
            return View(equipments);
        }

        // GET: /Equipment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipment equipment = db.Equipments.Find(id);
            if (equipment == null)
            {
                return HttpNotFound();
            }
            return View(equipment);
        }

        // GET: /Equipment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Equipment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipmentID,EquipmentDesignator,EquipmentDown,EquipmentDOT,EquipmentDOTDate,EquipmentDOTDateText,EquipmentReplacement,EquipmentNote,EquipmentText,EquipmentType,EquipmentPassengersAdult,EquipmentPassengersChild,EquipmentVideo,EquipmentVideo2,EquipmentBuiltIns,EquipmentWheelChair,EquipmentLocation,EquipmentLocationBook,EquipmentSelect,EquipmentInactive,EquipmentRadio,EquipmentRadioReported,EquipmentRadioNote")] Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                db.Equipments.Add(equipment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipment);
        }

        // GET: /Equipment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipment equipment = db.Equipments.Find(id);
            if (equipment == null)
            {
                return HttpNotFound();
            }
            return View(equipment);
        }

        // POST: /Equipment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipmentID,EquipmentDesignator,EquipmentDown,EquipmentDOT,EquipmentDOTDate,EquipmentDOTDateText,EquipmentReplacement,EquipmentNote,EquipmentText,EquipmentType,EquipmentPassengersAdult,EquipmentPassengersChild,EquipmentVideo,EquipmentVideo2,EquipmentBuiltIns,EquipmentWheelChair,EquipmentLocation,EquipmentLocationBook,EquipmentSelect,EquipmentInactive,EquipmentRadio,EquipmentRadioReported,EquipmentRadioNote")] Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipment);
        }

        // GET: /Equipment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipment equipment = db.Equipments.Find(id);
            if (equipment == null)
            {
                return HttpNotFound();
            }
            return View(equipment);
        }

        // POST: /Equipment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Equipment equipment = db.Equipments.Find(id);
            db.Equipments.Remove(equipment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
