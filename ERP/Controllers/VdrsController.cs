using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERP.Models;
using PagedList;

namespace ERP.Controllers
{
    public class VdrsController : Controller
    {
        private Entities db = new Entities();

        // GET: Vdrs
        public ActionResult List(string SortOrder, string Filter, string SearchString,int? page)
        {
            ViewData["SortOrder"] = SortOrder;
            //設定ViewData[""]要給View做 querystring
            ViewData["VdrNo_SortOrder"] = String.IsNullOrEmpty(SortOrder) ? "VdrNo_desc" : "";
            ViewData["VdrNa_SortOrder"] = SortOrder == "VdrNa" ? "VdrNa_desc" : "VdrNa";
            ViewData["VdrId_SortOrder"] = SortOrder == "VdrId" ? "VdrId_desc" : "VdrId";
            ViewData["VdrTel_SortOrder"] = SortOrder == "VdrTel" ? "VdrTel_desc" : "VdrTel";
            ViewData["VdrRmaTel_SortOrder"] = SortOrder == "VdrRmaTel" ? "VdrRmaTel_desc" : "VdrRmaTel";
            ViewData["VdrSalNa_SortOrder"] = SortOrder == "VdrSalNa" ? "VdrSalNa_desc" : "VdrSalNa";
            ViewData["VdrSalTel_SortOrder"] = SortOrder == "VdrSalTel" ? "VdrSalTel_desc" : "VdrSalTel";
            ViewData["VdrUrl_SortOrder"] = SortOrder == "VdrUrl" ? "VdrUrl_desc" : "VdrUrl";
            ViewData["VdrAdr_SortOrder"] = SortOrder == "VdrAdr" ? "VdrAdr_desc" : "VdrAdr";
            ViewData["VdrDtPay_SortOrder"] = SortOrder == "VdrDtPay" ? "VdrDtPay_desc" : "VdrDtPay";
            
            if(SearchString != null)
            { page = 1; }
            else
            { SearchString = Filter; }

            ViewData["Filter"] = SearchString;

            var vdrs = from s in db.Vdrs select s;
            if (!string.IsNullOrEmpty(SearchString))
            {
                vdrs = vdrs.Where( v => v.VdrNa.Contains(SearchString)
                                     || v.VdrNo.Contains(SearchString)
                );
            }

            //依照querystring做排序
            if (SortOrder == "VdrNo_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrNo);
            }
            if (SortOrder == "VdrNa")
            {
                vdrs = vdrs.OrderBy(s => s.VdrNa);
            }
            if (SortOrder == "VdrNa_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrNa);
            }
            if (SortOrder == "VdrId")
            {
                vdrs = vdrs.OrderBy(s => s.VdrId);
            }
            if (SortOrder == "VdrId_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrId);
            }
            if (SortOrder == "VdrTel")
            {
                vdrs = vdrs.OrderBy(s => s.VdrTel);
            }
            if (SortOrder == "VdrTel_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrTel);
            }
            if (SortOrder == "VdrRmaTel")
            {
                vdrs = vdrs.OrderBy(s => s.VdrRmaTel);
            }
            if (SortOrder == "VdrRmaTel_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrRmaTel);
            }
            if (SortOrder == "VdrSalNa")
            {
                vdrs = vdrs.OrderBy(s => s.VdrSalNa);
            }
            if (SortOrder == "VdrSalNa_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrSalNa);
            }
            if (SortOrder == "VdrSalTel")
            {
                vdrs = vdrs.OrderBy(s => s.VdrSalTel);
            }
            if (SortOrder == "VdrSalTel_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrSalTel);
            }
            if (SortOrder == "VdrUrl")
            {
                vdrs = vdrs.OrderBy(s => s.VdrUrl);
            }
            if (SortOrder == "VdrUrl_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrUrl);
            }
            if (SortOrder == "VdrAdr")
            {
                vdrs = vdrs.OrderBy(s => s.VdrAdr);
            }
            if (SortOrder == "VdrAdr_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrAdr);
            }
            if (SortOrder == "VdrDtPay")
            {
                vdrs = vdrs.OrderBy(s => s.VdrDtPay);
            }
            if (SortOrder == "VdrDtPay_desc")
            {
                vdrs = vdrs.OrderByDescending(s => s.VdrDtPay);
            }
            if (String.IsNullOrEmpty(SortOrder))
            {
                vdrs = vdrs.OrderBy(s => s.VdrNo);
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(vdrs.ToPagedList(pageNumber, pageSize));
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
