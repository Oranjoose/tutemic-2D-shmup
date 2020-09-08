extends Label

func _process(delta):
	if GameState.is_game_over:
		self.visible = true
