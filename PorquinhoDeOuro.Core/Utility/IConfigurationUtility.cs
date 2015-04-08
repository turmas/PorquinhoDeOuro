using System;

namespace PorquinhoDeOuro.Core.Utility {

    public interface IConfigurationUtility {

        string FileLogName { get; }
        string FullName { get; }
        string LogPath { get; }
    }
}
