﻿/sound
	var/file = null
	var/repeat = 0 as opendream_unimplemented
	var/wait = 0
	var/channel = 0
	var/volume = 100
	var/frequency = 0
	var/falloff = 1 as opendream_unimplemented
	var/x as opendream_unimplemented
	var/y as opendream_unimplemented
	var/z as opendream_unimplemented

	var/environment as opendream_unimplemented
	var/echo as opendream_unimplemented
	var/len as opendream_unimplemented

	var/priority = 0 as opendream_unimplemented
	var/status = 0 as opendream_unimplemented

	proc/New(file, repeat=0, wait, channel, volume)
		if (istype(file, /sound))
			var/sound/copy_from = file

			src.file = copy_from.file
			//src.repeat = copy_from.repeat
			src.wait = copy_from.wait
			src.channel = copy_from.channel
			src.volume = copy_from.volume
		else
			src.file = file
			//src.repeat = repeat
			if (wait != null) src.wait = wait
			if (channel != null) src.channel = channel
			if (volume != null) src.volume = volume