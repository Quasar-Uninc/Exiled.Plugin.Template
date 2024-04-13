using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Exiled.Plugin.Template
{
    /// <summary>
    /// Конфигурационный класс для настройки плагина.
    /// </summary>
    public class Config : IConfig
    {
        /// <summary>
        /// Включен ли плагин?
        /// </summary>
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Отображаются ли отладочные сообщения?
        /// </summary>
        [Description("Are debug messages displayed?")]
        public bool Debug { get; set; } = false;
    }
}
