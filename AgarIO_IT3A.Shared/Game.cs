namespace AgarIO_IT3A.Shared
{
  public class Game
  {
        public List<GameObject> gameObjects { get; }
        
    public Game()
    {
      gameObjects = new List<GameObject>();
           

    }

    public void AddGameObject(Player player)
        {
            gameObjects.Add(player);
        }

    public void AddGameObject(Food food)
        {
            gameObjects.Add(food);
        }
  }
}