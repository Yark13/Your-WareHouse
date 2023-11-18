using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DataLayer.Entities
{
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
        // Метод для отримання значень та описів елементів перерахування
        public static IEnumerable<EnumDescription> GetValues()
        {
            var values = Enum.GetValues(typeof(UnitOfMeasurement)).Cast<UnitOfMeasurement>();

            return values.Select(value => new EnumDescription
            {
                Value = value,
                Description = value.GetDescription()
            });
        }

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

    // Клас для представлення значення та опису елемента перерахування
    public class EnumDescription
    {
        public UnitOfMeasurement Value { get; set; }
        public string Description { get; set; }
    }
}

