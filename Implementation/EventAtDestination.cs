///////////////////////////////////////////////////////////
//  EventAtDestination.cs
//  Implementation of the Class EventAtDestination
//  Generated by Enterprise Architect
//  Created on:      18-jun-2014 01:26:32
//  Original author: Pierre
///////////////////////////////////////////////////////////




public class EventAtDestination : Event {

	public EventAtDestination(){

	}

	~EventAtDestination(){

	}

	/// 
	/// <param name="tracks"></param>
	public override bool CheckEventCond(tuple<ITrack, ITrack> tracks){

		return false;
	}

}//end EventAtDestination