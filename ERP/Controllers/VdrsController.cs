using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP.Models;

namespace ERP.Controllers
{
    public class VdrsController : Controller
    {
        private Entities db = new Entities();

        // GET: Vdrs
        public ActionResult List(string SortOrder)
        {
            var vdrs = from s in db.Vdrs select s;
            switch (SortOrder)
            {
                case "VdrNa_desc":
                    vdrs = vdrs.OrderByDescending(s => s.VdrNa);
                    break;
                case "VdrId ":
                    vdrs = vdrs.OrderBy(s => s.VdrId);                    
                    break;
                case "VdrId_desc":
                    vdrs = vdrs.OrderByDescending(s => s.VdrId);
                    break;
                case "VdrTel":
                    vdrs = vdrs.OrderBy(s => s.VdrTel);
                    break;
                case "VdrTel_desc ":
                    vdrs = vdrs.OrderByDescending(s => s.VdrTel);
                    break;
                case "VdrRmaTel ":
                    vdrs = vdrs.OrderBy(s => s.VdrRmaTel);
                    break;
                case "VdrRmaTel_desc":
                    vdrs = vdrs.OrderByDescending(s => s.VdrRmaTel);
                    break;
                case "VdrSalNa":
                    vdrs = vdrs.OrderBy(s => s.VdrSalNa);
                    break;
                case "VdrSalNa_desc ":
                    vdrs = vdrs.OrderByDescending(s => s.VdrSalNa);
                    break;
                case "VdrSalTel ":
                    vdrs = vdrs.OrderBy(s => s.VdrSalTel);
                    break;
                case "VdrSalTel_desc":
                    vdrs = vdrs.OrderByDescending(s => s.VdrSalTel);
                    break;
                case "VdrUrl":
                    vdrs = vdrs.OrderBy(s => s.VdrUrl);
                    break;
                case "VdrUrl_desc ":
                    vdrs = vdrs.OrderByDescending(s => s.VdrUrl);
                    break;
                case "VdrAdr":
                    vdrs = vdrs.OrderBy(s => s.VdrAdr);
                    break;
                case "VdrAdr_desc ":
                    vdrs = vdrs.OrderByDescending(s => s.VdrAdr);
                    break;
                case "VdrDtPay":
                    vdrs = vdrs.OrderBy(s => s.VdrDtPay);
                    break;
                case "VdrDtPay_desc ":
                    vdrs = vdrs.OrderByDescending(s => s.VdrDtPay);
                    break;
                default:  //預設就是VdrNa排序
                    vdrs = vdrs.OrderBy(s=>s.VdrNa);
                    break;
            }

            return View(vdrs);
        }

        // GET: Vdrs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdr vdr = db.Vdrs.Find(id);
            if (vdr == null)
            {
                return HttpNotFound();
            }
            return View(vdr);
        }

        // GET: Vdrs/Create
        public ActionResult Create()
        {
            Vdr vdr = new Vdr();
            return View(vdr);
        }

        // POST: Vdrs/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        //        public ActionResult Create([Bind(Include = "VdrNo,VdrNa,VdrId,VdrTel,VdrRmaTel,VdrSalNa,VdrSalTel,VdrUrl,VdrAdr,VdrDtPay,VdrDtC,VdrDtM,VdrRk,VdrEn",Exclude ="rowid")] Vdr vdr)
        public ActionResult Create([Bind(Exclude = "rowid")] Vdr vdr)
        {
            if (ModelState.IsValid)
            {
                db.Vdrs.Add(vdr);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(vdr);
        }

        // GET: Vdrs/Edit/5
        public ActionResult Edit(string Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdr vdr = db.Vdrs.Find(Id);
            if (vdr == null)
            {
                return HttpNotFound();
            }
            return View(vdr);
        }

        // POST: Vdrs/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VdrNo,VdrNa,VdrId,VdrTel,VdrRmaTel,VdrSalNa,VdrSalTel,VdrUrl,VdrAdr,VdrDtPay,VdrRk,VdrEn", Exclude = "rowid,VdrDtC,VdrDtM")] Vdr vdr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vdr).State = EntityState.Modified;
                db.Entry(vdr).Property(x => x.rowid).IsModified = false;
                db.Entry(vdr).Property(x => x.VdrDtC).IsModified = false;
                db.Entry(vdr).Property(x => x.VdrDtM).IsModified = false;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(vdr);
        }

        // GET: Vdrs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vdr vdr = db.Vdrs.Find(id);
            if (vdr == null)
            {
                return HttpNotFound();
            }
            return View(vdr);
        }

        // POST: Vdrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Vdr vdr = db.Vdrs.Find(id);
            db.Vdrs.Remove(vdr);
            db.SaveChanges();
            return RedirectToAction("List");
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
