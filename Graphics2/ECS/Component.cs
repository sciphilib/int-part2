using System;

namespace Graphics2.ECS
{
    public class Component
    {
        public Entity? Owner{ get; private set; }

        public Component()
        {
            Owner = null;
        }
        
        public void SetOwner(Entity entity)
        {
            Owner = entity;
        }
    }   
}