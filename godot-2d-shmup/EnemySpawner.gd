extends Node2D

export var _enemy_scene: PackedScene

func spawn_enemy() -> void:
	var new_enemy = _enemy_scene.instance() as Node2D
	self.add_child(new_enemy)
	
	var rand_x := rand_range(0, get_viewport_rect().size.x)
	new_enemy.position = Vector2(rand_x, -50)
