namespace knightmoves;

public class Classroom{

    public List<string> CreateTeam(string first, string second, string third){
        List<string> team = CreateTeam($"{first}", $"{second}", $"{third}");
        
        return team; 
    }
}