# Unity GUI to ROS

**About**

Sending values from a Unity GUI as rostopics, then receiving them and displaying them using ROS.

**Demo**

https://user-images.githubusercontent.com/98209046/171086204-4b5bbcc5-6093-46a9-8381-10881124724d.mp4

**Installation**

1\. If you don't already have a ROS environment, [set up a ROS environment](http://wiki.ros.org/ROS/Tutorials/InstallingandConfiguringROSEnvironment).

2\. Follow [this setup tutorial for ROS-Unity Integration](https://github.com/Unity-Technologies/Unity-Robotics-Hub/blob/main/tutorials/ros_unity_integration/setup.md). Setup for Unity except for setting the `ROS IP Address` and `ROS Port` should be avoided since the Unity project in the repository is already set up.

3\. Change the network adapter setting to `Bridged Adapter` and enter `ifconfig` on the Ubuntu terminal to get the `ROS IP Address` from `enp0s3`.

4\. When adding `unity_robotics_demo_msgs` from `tutorials/ros_unity_integration/ros_packages` into the `src` folder in your Catkin workspace, add `Value.msg` from this repository into the `unity_robotics_demo_msgs/msg` and replace `CMakeLists.txt` in `unity_robotics_demo_msgs` with `CMakeLists.txt` from this repository.

5\. Open the Unity project from this repository with Unity and follow the demo video. Use [ROS–Unity Demo Setup](https://github.com/Unity-Technologies/Unity-Robotics-Hub/blob/main/tutorials/ros_unity_integration/setup.md) and [ROS–Unity Integration: Publisher](https://github.com/Unity-Technologies/Unity-Robotics-Hub/blob/main/tutorials/ros_unity_integration/publisher.md) for reference.
