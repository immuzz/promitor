﻿using System.Collections.Generic;
using Promitor.Core.Scraping.Configuration.Model.Metrics;

namespace Promitor.Scraper.Host.Validation.MetricDefinitions.Interfaces
{
    public interface IMetricValidator<in TMetricDefinition>
        where TMetricDefinition : MetricDefinition
    {
        /// <summary>
        ///     Validates a specific metric definition
        /// </summary>
        /// <param name="metricDefinition">Metric definition to validate</param>
        /// <returns>List of validation errors</returns>
        // ReSharper disable once UnusedMember.Global
        List<string> Validate(TMetricDefinition metricDefinition);
    }
}