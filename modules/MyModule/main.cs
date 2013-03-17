	exec("./gui/guiProfiles.cs");
	exec("./scripts/scenewindow.cs");
	exec("./scripts/scene.cs");
	exec("./scripts/background.cs");
	exec("./scripts/ground.cs");
function MyModule::create( %this )
{
	// Load GUI profiles.

	createSceneWindow();
	createScene();
	mySceneWindow.setScene(myScene);
	createBackground();
	createGround();
	createGrass();
}

function MyModule::destroy( %this )
{
	destroySceneWindow();
}