
# react-native-hunter-library

## Getting started

`$ npm install react-native-hunter-library --save`

### Mostly automatic installation

`$ react-native link react-native-hunter-library`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-hunter-library` and add `RNHunterLibrary.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNHunterLibrary.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNHunterLibraryPackage;` to the imports at the top of the file
  - Add `new RNHunterLibraryPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-hunter-library'
  	project(':react-native-hunter-library').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-hunter-library/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-hunter-library')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNHunterLibrary.sln` in `node_modules/react-native-hunter-library/windows/RNHunterLibrary.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Hunter.Library.RNHunterLibrary;` to the usings at the top of the file
  - Add `new RNHunterLibraryPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNHunterLibrary from 'react-native-hunter-library';

// TODO: What to do with the module?
RNHunterLibrary;
```
  