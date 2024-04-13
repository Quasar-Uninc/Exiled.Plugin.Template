using System;
using Exiled.API.Features;

namespace Exiled.Plugin.Template
{
    /// <summary>
    /// Класс плагина для Exiled.Plugin.Template.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Exiled.Plugin.Template";
        public override string Author => "Quasar-Uninc.";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 8, 0);

        public static Plugin Instance;
        private EventHandlers _handlers;

        /// <summary>
        /// Вызывается при включении плагина.
        /// </summary>
        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();

            Log.Info("Exiled.Plugin.Template был включен.");
            base.OnEnabled();
        }

        /// <summary>
        /// Вызывается при отключении плагина.
        /// </summary>
        public override void OnDisabled()
        {
            Instance = null;
            UnregisterEvents();

            Log.Info("Exiled.Plugin.Template был отключен.");
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            // Регистрация обработчиков событий
            _handlers = new EventHandlers();
        }

        private void UnregisterEvents()
        {
            // Отмена регистрации обработчиков событий
            _handlers = null;
        }
    }
}
