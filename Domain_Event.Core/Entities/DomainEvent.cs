using System;
using System.Collections.Generic;
using Domain_Event.Core.Interfaces;

namespace Domain_Event.Core.Entities
{
    public static class DomainEvent
    {
        [ThreadStatic]
        private static List<Delegate> _actions;

        public static IServiceProvider _serviceProvider { get; set; }

        
        public static void Register<T>(Action<T> callback) where T : IDomainEvent
        {
            _actions = _actions ?? new List<Delegate>();
            _actions.Add(callback);
        }

        public static void ClearCallbacks()
        {
            _actions = null;
        }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            if (_serviceProvider != null)
            {
                //Fetch all handler of this type from the IoC container and invoke their handle method.
                foreach (var handler in (IEnumerable<IDomainHandler<T>>)_serviceProvider.GetService(typeof(IEnumerable<IDomainHandler<T>>)))
                {
                    handler.Hanle(args);
                }
            }
            
            if (_actions != null)
            {
                foreach (var action in _actions)
                {
                    if (action is Action<T>)
                    {
                        ((Action<T>) action)(args);
                    }
                }
            }
        }
    }
}