// THIS IS AN EXAMPLE OF MULTIPLE EXEC PINS IN AN UNREAL FUNCTION
//EOutcomePins is an enum
void ATestPins :: RandomizeActorSize(AActor*targer,bool isSuccess,TEnumAsByte<EOutcomePins>&Outcome)
{
    if(isSuccess)
        OutCome = EOutcomePins::Success;
    else
        OutCome = EOutcomePins::Failure;
}
