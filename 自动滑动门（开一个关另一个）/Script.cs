//控制一组两个滑动门不能同时打开，外面的门名字改成dooroutside，里面的门名字改成doorinside。
//此脚本作者:Kc ， Steam：（https://steamcommunity.com/id/scarletkc/）

IMyDoor dooroutside;
IMyDoor doorinside;

public Program()
{
	dooroutside = GridTerminalSystem.GetBlockWithName("dooroutside") as IMyDoor;
	doorinside = GridTerminalSystem.GetBlockWithName("doorinside") as IMyDoor;
	Runtime.UpdateFrequency = UpdateFrequency.Update10;
}

public void Main(string argument, UpdateType updateSource)
{

	if( dooroutside.Status == DoorStatus.Opening )
	{
		doorinside.CloseDoor();
			
	}
	if(doorinside.Status == DoorStatus.Opening)	
	{
		dooroutside.CloseDoor();
	}		

}