using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cv.Api.DependencyInjection
{
    public static class ServiceProviderExtensions
    {

        /// <summary>
        /// Adds transient services of all types implementing the type specified in <typeparamref name="TClassBase"/>, from an assembly where <typeparamref name="TTypeInAssembly"/> is defined, with the name of the implemented type ending with <paramref name="classNameEndsWith"/>.
        /// </summary>
        /// <typeparam name="TTypeInAssembly">The type to identify the assembly by.</typeparam>
        /// <typeparam name="TClassBase">The base type to add a implementations as a service for.</typeparam>
        /// <param name="classNameEndsWith">The ending of the name of the implmented type.</param>
        /// <returns></returns>
        public static IServiceCollection AddClassesAsServices<TTypeInAssembly, TClassBase>(this IServiceCollection services, string classNameEndsWith)
        {
            var classTypes = GetClassTypes<TTypeInAssembly, TClassBase>()
               .Where(t => t.Name.EndsWith(classNameEndsWith));

            return services.AddClassesAsServices(classTypes);
        }

        /// <summary>
        /// Adds transient services of all types implementing the type specified in <typeparamref name="TClassBase"/>, from an assembly where <typeparamref name="TTypeInAssembly"/> is defined.
        /// </summary>
        /// <typeparam name="TTypeInAssembly">The type to identify the assembly by.</typeparam>
        /// <typeparam name="TClassBase">The base type to add a implementations as a service for.</typeparam>
        public static IServiceCollection AddClassesAsServices<TTypeInAssembly, TClassBase>(this IServiceCollection services)
        {
            var classTypes = GetClassTypes<TTypeInAssembly, TClassBase>();

            return services.AddClassesAsServices(classTypes);
        }

        /// <summary>
        /// Adds transient services of the specified types.
        /// </summary>
        /// <param name="classTypes">The collection whose elements should be added as a transient service.</param>
        /// <returns></returns>
        private static IServiceCollection AddClassesAsServices(this IServiceCollection services, IEnumerable<Type> classTypes)
        {
            foreach (var type in classTypes)
                services.AddTransient(type);

            return services;
        }

        /// <summary>
        /// Retrieves all implementations of <typeparamref name="TClassBase"/> from the assembly, which defines <typeparamref name="TTypeInAssembly"/>.
        /// </summary>
        /// <typeparam name="TTypeInAssembly">The type to identify the assembly by.</typeparam>
        /// <typeparam name="TClassBase">The base type to add a implementations as a service for.</typeparam>
        /// <returns></returns>
        private static IEnumerable<Type> GetClassTypes<TTypeInAssembly, TClassBase>()
        {
            return typeof(TTypeInAssembly).Assembly.GetExportedTypes()
               .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition)
               .Where(t => typeof(TClassBase).IsAssignableFrom(t));
        }
    }
}