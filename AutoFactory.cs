using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPattern.BasicExample
{
    public class AutoFactory
    {
        private Dictionary<string, Type> _autos;

        public AutoFactory()
        {
            LoadTypesICanReturn();
        }

        public IAuto CreateInstance(string carManf)
        {
            var t = GetTypeToCreate(carManf);

            if (t == null)
            {
                return null;
            }

            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(string carManf)
        {
            foreach (var auto in _autos)
            {
                if (auto.Key.Contains(carManf))
                {
                    return _autos[auto.Key];
                }
            }

            return null;
        }

        private void LoadTypesICanReturn()
        {
            _autos = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof (IAuto).ToString()) != null)
                {
                    _autos.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}