﻿using System.Collections.Generic;

namespace Grace.DependencyInjection.Impl
{
    /// <summary>
    /// interface to provide activation strategies
    /// </summary>
    public interface IExportRegistrationBlockValueProvider : IExportRegistrationBlock
    {
        /// <summary>
        /// Export strategies from the registration block
        /// </summary>
        /// <returns></returns>
        IEnumerable<ICompiledExportStrategy> GetExportStrategies();

        /// <summary>
        /// Decorators from the registration block
        /// </summary>
        /// <returns></returns>
        IEnumerable<ICompiledDecoratorStrategy> GetDecoratorStrategies();

        /// <summary>
        /// Wrappers from the registration block
        /// </summary>
        /// <returns></returns>
        IEnumerable<ICompiledWrapperStrategy> GetWrapperStrategies();

        /// <summary>
        /// Get inspectors registered in block
        /// </summary>
        /// <returns></returns>
        IEnumerable<IActivationStrategyInspector> GetInspectors();

        /// <summary>
        /// Get list of missing export strategy providers
        /// </summary>
        /// <returns></returns>
        IEnumerable<IMissingExportStrategyProvider> GetMissingExportStrategyProviders();

        /// <summary>
        /// Get list of value providers
        /// </summary>
        /// <returns></returns>
        IEnumerable<IInjectionValueProvider> GetValueProviders();
    }
}
