// THIS IS AN EXAMPLE OF MULTIPLE EXEC PINS IN AN UNREAL FUNCTION
//EOutcomePins is an enum
UFUNCTION(Blueprint Callable,meta=(ExpandEnumAsExecs = "VarName"))
void ATestPins :: RandomizeActorSize(AActor*targer,bool isSuccess,TEnumAsByte<EOutcomePins> &VarName)
{
    if(isSuccess)
        OutCome = EOutcomePins::Success;
    else
        OutCome = EOutcomePins::Failure;
}

//Spawn Components From Components at runtime
NewObject(ParentClass, StaticClassToSpawn, Name);
NewObject(GetOwner(), Component->StaticClass(), FName("Actor Component"));
