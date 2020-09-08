extends Node2D

export var _speed: float = 200

func _process(delta):
	position.y += _speed * delta


func _on_Area2D_area_entered(other_area: Area2D):
	self.queue_free()  # destroy
	other_area.get_parent().queue_free()
	GameState.increase_score(10)
	
	if other_area.get_parent() is Player:
		GameState.initiate_game_over()
