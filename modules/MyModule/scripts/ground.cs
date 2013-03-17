function createGround()
{
    %ground = new Sprite();
    %ground.setBodyType( static );
    %ground.Position = "0 -35";
    %ground.Size = "100 5";
    %ground.SceneLayer = 30;
    %ground.Image = "ToyAssets:dirtGround";
	%ground.setDefaultRestitution(1);
	myScene.add( %ground ); 
}
function createGrass()
{
	%grass = new Sprite();
	%grass.4r ( static );
    %grass.Position = "0 -31.45";
    %grass.Size = "100 5";
    %grass.SceneLayer = 29;
    %grass.Image = "ToyAssets:grassForeground";
	%grass.setDefaultRestitution(1);
	myScene.add( %grass ); 
}