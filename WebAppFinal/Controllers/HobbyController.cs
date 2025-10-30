using Microsoft.AspNetCore.Mvc;
using WebAppFinal.Repositories;

namespace WebAppFinal.Controllers;

public class HobbyController : Controller
{
    private readonly IDirtBikeRepository _dirtBikeRepository;
    private readonly IDistanceRunningRepository _distanceRunningRepository;

    public HobbyController(IDirtBikeRepository dirtBikeRepository, IDistanceRunningRepository distanceRunningRepository)
    {
        _dirtBikeRepository = dirtBikeRepository;
        _distanceRunningRepository = distanceRunningRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult DirtBikes()
    {
        var dirtBikes = _dirtBikeRepository.GetAll();
        return View(dirtBikes);
    }

    public IActionResult DirtBikeDetails(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var dirtBike = _dirtBikeRepository.GetById(id.Value);
        if (dirtBike == null)
        {
            return NotFound();
        }

        return View(dirtBike);
    }

    public IActionResult DistanceRuns()
    {
        var distanceRuns = _distanceRunningRepository.GetAll();
        return View(distanceRuns);
    }

    public IActionResult DistanceRunDetails(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var distanceRun = _distanceRunningRepository.GetById(id.Value);
        if (distanceRun == null)
        {
            return NotFound();
        }

        return View(distanceRun);
    }
}
