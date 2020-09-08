extends Node2D

export var _speed: float = 200

func _process(delta):
	position.y -= _speed * delta
	
