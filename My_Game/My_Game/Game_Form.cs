using Space_Shooters.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using My_Game.BL;

namespace My_Game
{
    public partial class Game_Form : Form
    {
        Game_Grid grid;
        Space_Shooter_Player player;
        Horizontal_Ghost horizontal_ghost1;
        Horizontal_Ghost horizontal_ghost2;
        Random_Ghost random;

        List<Ghost> ghosts = new List<Ghost>();
        List<Firing> firing = new List<Firing>();
        List<Firing> Player_firing=new List<Firing>();

        int player_firing_counter = 0;
        int enemy_firing_counter = 0;
        int random_firing_counter = 0;

        int playerhealth = 100;
        int enemy1health = 100;
        int enemy2health = 100;

        int life = 3;

        bool is_Generate_Bullet = false;
        public Game_Form()
        {
            InitializeComponent();
            this.BackgroundImage = My_Game.Properties.Resources.space_2;
            this.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void Game_Form_Load(object sender, EventArgs e)
        {
            grid = new Game_Grid("Maze.txt", 10, 16);

            Image Space_Shooter_Image = Game.getGameObjectImage('S');
            Image Horizontal_Image1 = Game.getGameObjectImage('E');
            Image Horizontal_Image2 = Game.getGameObjectImage('e');
            Image Random_Image = Game.getGameObjectImage('R');
            Image Fire = Game.getGameObjectImage('|');
            Image Rand_Image = Game.getGameObjectImage('@');

            Game_Cell start = new Game_Cell(6, 8, grid);
            Game_Cell Horizontal_Start1 = new Game_Cell(1, 6 , grid);
            Game_Cell Horizontal_Start2 = new Game_Cell(3, 5, grid);
            Game_Cell Random_Start = new Game_Cell(3, 8, grid);

            player = new Space_Shooter_Player(Space_Shooter_Image, start);
            horizontal_ghost1 = new Horizontal_Ghost(Horizontal_Image1, Horizontal_Start1, Game_Direction.Right) { Health = 12 };
            horizontal_ghost2 = new Horizontal_Ghost(Horizontal_Image2, Horizontal_Start2, Game_Direction.Left) { Health = 12 };
            random = new Random_Ghost(Random_Image, Random_Start) { Health = 12 };

            ghosts.Add(horizontal_ghost1);
            ghosts.Add(horizontal_ghost2);
            ghosts.Add(random);

            printMaze(grid);
        }
        void printMaze(Game_Grid grid)
        {
            for (int x = 0; x < grid.rows; x++)
            {
                for (int y = 0; y < grid.cols; y++)
                {
                    Game_Cell cell = Game_Grid.Get_Cell(x, y);
                    this.Controls.Add(cell.PictureBox);

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                MovePlayer(Game_Direction.Right);
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                MovePlayer(Game_Direction.Left);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                MovePlayer(Game_Direction.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                MovePlayer(Game_Direction.Down);
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                player_firing_counter += 1;
                Generate_Fire_Player();
            }

            
            Generate_Fire_Enemy();

            
            MoveGhosts();

           
            MoveEnemyFiring();

            
            HandlePlayerHealth();

           
            MovePlayerFiring();
            if (enemy1health == 0 && enemy2health == 0)
            {
                
                timer1.Stop();

              
            }
           



            enemy_firing_counter += 1;
            random_firing_counter += 1;
        }

        private void MovePlayer(Game_Direction direction)
        {
            player.move(direction);

            if (player.Get_Flag() && progressBar1.Value >= 100)
            {
                progressBar1.Value -= 100;
                player.PLayer_Collide_Enemy_Fire1 = false;
            }

            if (player.Get_Flag2() && progressBar1.Value >= 100)
            {
                progressBar1.Value -= 100;
                player.PLayer_Collide_Enemy1 = false;
            }
        }

        private void MoveGhosts()
        {
            foreach (Ghost ghost in ghosts.ToList())
            {
                ghost.Move();

                if (ghost.Get_Flag())
                {
                    ghost.Current_cell.PictureBox.Image = Properties.Resources.transparent1;
                    ghosts.Remove(ghost);
                    break;
                }
            }

            // Check if all enemies are destroyed
            if (ghosts.Count == 0)
            {

                GameWinFrm win = new GameWinFrm();
                win.Show();
                timer1.Stop();
                timer1.Tick -= timer1_Tick;

                this.Hide();
                



            }
        }


        private void MoveEnemyFiring()
        {
            foreach (Firing fire in firing.ToList())
            {
                fire.MoveBulletOfEnemy();

                if (fire.Iscollision)
                {
                    fire.Current_cell.PictureBox.Image = My_Game.Properties.Resources.transparent1;
                    firing.Remove(fire);
                    break;
                }
            }
        }

        private void HandlePlayerHealth()
        {
            if (progressBar1.Value == 0 && life > 0)
            {
                if (life == 3)
                {
                    pictureBox2.Hide();
                    progressBar1.Value = 100;
                    life--;
                }
                else if (life == 2)
                {
                    pictureBox1.Hide();
                    progressBar1.Value = 100;
                    life--;
                }
                else if (life == 1)
                {
                    pbHeart1.Hide();
                    timer1.Stop(); 
                    GameOver game_Over = new GameOver();
                    game_Over.Show();
                    this.Hide();
                }
            }
        }

        private void MovePlayerFiring()
        {
            foreach (Firing fire in Player_firing.ToList())
            {
                fire.MoveBulletOfPlayer();

                // Check collision with the enemy
                if (fire.Iscollision || fire.Iscollision_EnemyFire)
                {
                    // Reduce enemy health by 1 for each bullet hit
                    Ghost enemy = fire.Current_cell.Currentobj as Ghost;
                    if (enemy != null)
                    {
                        enemy.Health--;
                        
                       
                        if (enemy.Health <= 0)
                        {
                            // Enemy is destroyed when its health reaches 0 or below
                            fire.Current_cell.PictureBox.Image = My_Game.Properties.Resources.transparent1;
                            Player_firing.Remove(fire);
                            this.Hide();
                            GameWinFrm gameWinFrm = new GameWinFrm(); 
                            gameWinFrm.Show();

                        }
                    }
                }
            }
        }


        private void Generate_Fire_Enemy()
        {

            if (enemy_firing_counter % 10 == 0)
            {
                Image Fire1 = Game.getGameObjectImage('.');
                Game_Cell start1 = new Game_Cell(horizontal_ghost1.Current_cell.Rows + 1, horizontal_ghost1.Current_cell.Cols, grid);
                Firing fire1 = new Firing(Fire1, start1, Game_Object_Type.Enemy_Fire);

                Image Fire2 = Game.getGameObjectImage('.');
                Game_Cell start2 = new Game_Cell(horizontal_ghost2.Current_cell.Rows + 1, horizontal_ghost2.Current_cell.Cols, grid);
                Firing fire2 = new Firing(Fire2, start2, Game_Object_Type.Enemy_Fire);

                firing.Add(fire1);
                firing.Add(fire2);
            }

       
        }

        private void Generate_Fire_Player()
        {        
            Image Fire = Game.getGameObjectImage('*');
            Game_Cell start = new Game_Cell(player.Current_cell.Rows - 1, player.Current_cell.Cols, grid);
            Firing fire = new Firing(Fire, start, Game_Object_Type.Fire);

            Player_firing.Add(fire);
   

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
