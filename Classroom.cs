namespace knightmoves;

public class Classroom{

    public List<string> CreateTeam(string first, string second, string third){
        var classroom = new Classroom();

        List<string> team = classroom.CreateTeam($"{first}", $"{second}", $"{third}");
        
        return team; 
    }
}