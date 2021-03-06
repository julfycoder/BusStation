﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CourseWork_BusStation_Console.Model.BusStationEntity
{
    class EntityBuilder
    {
        object entity;
        public void SetEntity(object entity)
        {
            this.entity = entity;
        }
        public void SetEntityProperty(string propertyName, object value)
        {
            string propName = propertyName;
            PropertyInfo property = entity.GetType().GetProperty(propertyName);
            if (value == DBNull.Value) value = null;
            property.SetValue(entity, value, null);
        }
        public object BuildEntity() { return entity; }
    }
}