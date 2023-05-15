using Microsoft.AspNetCore.Mvc;
using MobileStore.Gateway.Bll.Interfaces;
using MobileStore.Gateway.Common.RequestModels;
using MobileStore.Gateway.Common.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileStore.Gateway.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService orderService;

	public OrderController(IOrderService orderService)
	{
		this.orderService = orderService;
	}

    public async Task<IActionResult> CreateOrder(int userId, CreateOrderRequestModel model)
    {
        if (userId < 1)
        {
            return BadRequest();
        }

        var orderId = await orderService.CreateOrder(userId, model);

        return CreatedAtAction(nameof(GetOrderDetails), new { orderId }, model);
    }

    public Task<IActionResult> GetAllOrders(int userId)
    {
        throw new System.NotImplementedException();
    }

    public Task<IActionResult> GetOrderDetails(int orderId)
    {
        throw new System.NotImplementedException();
    }

    public Task<IActionResult> UpdateOrder(UpdateOrderRequestModel model)
    {
        throw new System.NotImplementedException();
    }
}
