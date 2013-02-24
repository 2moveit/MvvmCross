﻿// PluginLoader.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore.Interfaces.Plugins;
using Cirrious.CrossCore.Interfaces.ServiceProvider;

namespace Cirrious.MvvmCross.Plugins.JsonLocalisation
{
    public class PluginLoader
        : IMvxPluginLoader
          , IMvxProducer
    {
        public static readonly PluginLoader Instance = new PluginLoader();

        private bool _loaded;

        #region Implementation of IMvxPluginLoader

        public void EnsureLoaded()
        {
            if (_loaded)
            {
                return;
            }

            this.RegisterServiceType<IMvxTextProviderBuilder, MvxTextProviderBuilder>();
            _loaded = true;
        }

        #endregion
    }
}