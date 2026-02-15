extends Node2D
class_name CallerNode
@export var friend : Reciever
# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	print("hello there my good friend")
	friend.oncall()
