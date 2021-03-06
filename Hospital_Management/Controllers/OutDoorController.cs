using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using Hospital_Management.Models;
using Hospital_Management.CustomLogics;

namespace Hospital_Management.Controllers
{
    public class OutDoorController : Controller
    {
        Hospital_DBEntities hdb = new Hospital_DBEntities();

        [Route("OutDoorReg")]
        public ActionResult OutDoorReg()
        {
            ViewBag.page = "OutDoor";
            OutDoorPatient outDoorPatient = new OutDoorPatient();
            outDoorPatient.Outer_ID = HMCustomLogics.getAutoIncreamentId(hdb.Out_Door.Select(x => x.Id).Count(),"OT");

            outDoorPatient.Patient_Id= HMCustomLogics.getAutoIncreamentId(hdb.Tbl_Patient.Select(x => x.Id).Count(), "PT");


            outDoorPatient.Patient_DOB = DateTime.Now.Date;

            

            return View(outDoorPatient);
        }

        [HttpPost]
        public ActionResult OutDoorReg(OutDoorPatient obj)
        {
            if (ModelState.IsValid)
            {
                using (Hospital_DBEntities db = new Hospital_DBEntities())
                {
                    try
                    {
                        Out_Door OD = new Out_Door();
                        Tbl_Patient PT = new Tbl_Patient();

                        OD.Outer_ID = obj.Outer_ID;
                        OD.Date = obj.Date;
                        OD.Patient_Id = obj.Patient_Id;
                        OD.Docter_Name = obj.Docter_Name;
                        OD.Comment = obj.Comment;
                        OD.Docter_fee = obj.Docter_fee;
                        OD.Reg_fee = obj.Reg_fee;
                        OD.Other_dorfee = obj.Other_dorfee;
                        OD.Office = obj.Office;

                        PT.Patient_Id = obj.Patient_Id;
                        PT.Patient_Name = obj.Patient_Name;
                        PT.Patient_DOJ = obj.Patient_DOJ;
                        PT.Patient_DOB = obj.Patient_DOB;
                        PT.Patient_Age = obj.Patient_Age;
                        PT.Patient_Address = obj.Patient_Address;
                        PT.Patient_MobileNo = obj.Patient_MobileNo;
                        PT.Patient_EmailId = obj.Patient_EmailId;
                        PT.type = obj.type;
                        PT.sex = obj.sex;
                        PT.Hight = obj.Hight;
                        PT.Weight = obj.Weight;
                        PT.BP = obj.BP;
                        PT.Care_of = obj.Care_of;
                        PT.Care_of_Name = obj.Care_of_Name;

                        db.Out_Door.Add(OD);
                        db.Tbl_Patient.Add(PT);
                        db.SaveChanges();



                        OutDoorPatient outDoorPatient = new OutDoorPatient();
                        outDoorPatient.Outer_ID = HMCustomLogics.getAutoIncreamentId(hdb.Out_Door.Select(x => x.Id).Count(), "OT");
                        return View(outDoorPatient);
                    }
                    catch (Exception)
                    {
                        OutDoorPatient outDoorPatient = new OutDoorPatient();
                        outDoorPatient.Outer_ID = HMCustomLogics.getAutoIncreamentId(hdb.Out_Door.Select(x => x.Id).Count(), "OT");
                        return View(outDoorPatient);
                    }
                }
            }
            else
            {
                return View();
            }
          
        }


        public ActionResult OutDoorList()
        {
            return View();
        }

        //private string generatesno()
        //{
        //    using (Hospital_DBEntities db = new Hospital_DBEntities())
        //    {
        //        var lastId = db.Tbl_AutoIncreament.Where(x => x.TypeName == "outDoor").FirstOrDefault();
        //        var newId = HMCustomLogics.getAutoIncreamentId(lastId.TypeLastValue);
        //        return newId;
        //    }
        //}

        //Add Function
    }
}