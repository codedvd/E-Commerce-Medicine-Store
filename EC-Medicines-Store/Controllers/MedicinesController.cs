using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using EC_Medicines_Store.Models;
using System.Data.SqlClient;

namespace EC_Medicines_Store.Controllers;


[Route("api/[controller]")]
[ApiController]
public class MedicinesController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public MedicinesController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpPost]
    [Route("addCart")]
    public Response addToCart(Cart cart)
    {
        DAL dal = new DAL();
        SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedsCS").ToString());
        Response response = dal.addToCart(cart, connection);
        return response;
    }

    [HttpPost]
    [Route("placeOrder")]
    public Response placeOrder(Users users)
    {
        DAL dal = new DAL();
        SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedsCS").ToString());
        Response response = dal.placeOrder(users, connection);
        return response;
    }

    [HttpPost]
    [Route("orderList")]
    public Response orderList(Users users)
    {
        DAL dal = new DAL();
        SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedsCS").ToString());
        Response response = dal.orderList(users, connection);
        return response;
    }

}
