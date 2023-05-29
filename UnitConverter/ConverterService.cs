using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class ConverterService
    {
        public double ConvertMassUnit(MassEnum from, MassEnum to, double amount)
        {
            double converterValue = 0;

            switch (from)
            {
                case MassEnum.Miligram:
                    {
                        switch (to)
                        {
                            case MassEnum.Gram:
                                converterValue = amount / 100;
                                break;
                            case MassEnum.Kilogram:
                                converterValue = amount / 1000000;
                                break;
                        }
                    }
                    break;
                case MassEnum.Gram:
                    {
                        switch (to)
                        {
                            case MassEnum.Miligram:
                                converterValue = amount * 1000;
                                break;
                            case MassEnum.Kilogram:
                                converterValue = amount / 1000;
                                break;
                        }
                    }
                    break;
                case MassEnum.Kilogram:
                    {
                        switch (to)
                        {
                            case MassEnum.Gram:
                                converterValue = amount * 1000;
                                break;
                            case MassEnum.Miligram:
                                converterValue = amount * 1000000;
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }


            return converterValue;
        }

        public double ConvertTemperatureUnit(TemperatureEnum from, TemperatureEnum to, double amount)
        {
            double converterValue = 0;

            switch (from)
            {
                case TemperatureEnum.Celsius:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Fahrenheit:
                                converterValue = (amount * 1.8) + 32;
                                break;
                            case TemperatureEnum.Kelvin:
                                converterValue = amount + 273.15;
                                break;
                        }
                    }
                    break;
                case TemperatureEnum.Fahrenheit:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Celsius:
                                converterValue = (amount - 32) * 1.8;
                                break;
                            case TemperatureEnum.Kelvin:
                                converterValue = (amount - 32) * 1.8 + 273.15;
                                break;
                        }
                    }
                    break;
                case TemperatureEnum.Kelvin:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Celsius:
                                converterValue = amount - 273.15;
                                break;
                            case TemperatureEnum.Fahrenheit:
                                converterValue = (amount - 273.15) * 1.8 + 32;
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }


            return converterValue;
        }
        public double ConvertTimeUnit(TimeEnum from, TimeEnum to, double amount)
        {
            double converterValue = 0;

            switch (from)
            {
                case TimeEnum.Miliseconds:
                    {
                        switch (to)
                        {
                            case TimeEnum.Seconds:
                                converterValue = amount / 1000;
                                break;
                            case TimeEnum.Minutes:
                                converterValue = amount / 60000;
                                break;
                            case TimeEnum.Hours:
                                converterValue = amount / 3600000;
                                break;
                        }
                    }
                    break;
                case TimeEnum.Seconds:
                    {
                        switch (to)
                        {
                            case TimeEnum.Miliseconds:
                                converterValue = amount * 100;
                                break;
                            case TimeEnum.Minutes:
                                converterValue = amount / 60;
                                break;
                            case TimeEnum.Hours:
                                converterValue = amount / 3600;
                                break;
                        }
                    }
                    break;
                case TimeEnum.Minutes:
                    {
                        switch (to)
                        {
                            case TimeEnum.Miliseconds:
                                converterValue = amount * 60000;
                                break;
                            case TimeEnum.Seconds:
                                converterValue = amount * 60;
                                break;
                            case TimeEnum.Hours:
                                converterValue = amount / 60;
                                break;
                        }
                    }
                    break;
                case TimeEnum.Hours:
                    {
                        switch (to)
                        {
                            case TimeEnum.Miliseconds:
                                converterValue = amount * 3600000;
                                break;
                            case TimeEnum.Seconds:
                                converterValue = amount * 3600;
                                break;
                            case TimeEnum.Minutes:
                                converterValue = amount * 60;
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }

            return converterValue;
        }
    }
}


