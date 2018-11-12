using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Hunter.Library.RNHunterLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNHunterLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNHunterLibraryModule"/>.
        /// </summary>
        internal RNHunterLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNHunterLibrary";
            }
        }
    }
}
