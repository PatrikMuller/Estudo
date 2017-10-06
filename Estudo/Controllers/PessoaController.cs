﻿using Estudo.Data_Access;
using Estudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estudo.Controllers
{
    public class PessoaController : Controller
    {
        //private PessoaAccess dao;

        //
        // GET: /Pessoa/
        public ActionResult Index()
        {
            PessoaAccess dao = new PessoaAccess();
            IList<Pessoa> posts = dao.Lista();
            return View(posts);
        }

        public ActionResult Form(int? id)
        {
            PessoaAccess dao = new PessoaAccess();
            Pessoa obj = id == null ? new Pessoa() : dao.BuscaPorId(Convert.ToInt32(id));
            return View(obj);
        }
                
        [HttpPost] //Força esse método aceitar por post
        public ActionResult Grava(Pessoa obj)
        {
            if (ModelState.IsValid)
            {
                PessoaAccess dao = new PessoaAccess();
                
                dao.Grava(obj);

                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", obj);
            }
        }


	}
}