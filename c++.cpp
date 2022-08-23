// THIS IS AN EXAMPLE OF MULTIPLE EXEC PINS IN AN UNREAL FUNCTION
//EOutcomePins is an enum
void ATestPins :: RandomizeActorSize(AActor*targer,bool isSuccess,TEnumAsByte<EOutcomePins>&Outcome)
{
    if(isSuccess)
        OutCome = EOutcomePins::Success;
    else
        OutCome = EOutcomePins::Failure;
}

//Spawn Components From Components
NewObject(ParentClass, StaticClassToSpawn, Name);
NewObject(GetOwner(), Component->StaticClass(), FName("Actor Component"));
