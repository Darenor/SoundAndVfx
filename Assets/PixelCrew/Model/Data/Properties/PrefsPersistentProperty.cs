﻿namespace PixelCrew.Model.Data.Properties
{
    public abstract class PrefsPersistentProperty<TPropertyType> : PersistenProperty<TPropertyType>
    {
        protected string Key;

        protected PrefsPersistentProperty(TPropertyType defaultValue, string key) : base(defaultValue)
        {
            Key = key;
        }
    }
}
