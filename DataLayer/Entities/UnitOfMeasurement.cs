using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities;

public enum UnitOfMeasurement
{
    KiloGrams,
    Tons,
    Liters,
    CubicMeters,
    KiloTons,
    Thinks,
    SquareMeters,
    Sets,
    Barrels
}

public static class UnitOfMeasurementExtensions
{
    public static string GetDescription(this UnitOfMeasurement unit)
    {
        switch (unit)
        {
            case UnitOfMeasurement.KiloGrams:
                return "kg";
            case UnitOfMeasurement.Tons:
                return "T";
            case UnitOfMeasurement.Liters:
                return "L";
            case UnitOfMeasurement.CubicMeters:
                return "m3";
            case UnitOfMeasurement.KiloTons:
                return "kT";
            case UnitOfMeasurement.Thinks:
                return "thinks";
            case UnitOfMeasurement.SquareMeters:
                return "m2";
            case UnitOfMeasurement.Sets:
                return "sets";
            case UnitOfMeasurement.Barrels:
                return "barrel";
            default:
                return unit.ToString();
        }
    }
}

