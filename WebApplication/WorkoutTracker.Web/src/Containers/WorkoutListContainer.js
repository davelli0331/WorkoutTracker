import React from 'react';
import { Container } from 'flux/utils';
import WorkoutTemplateStore from '../Stores/WorkoutTemplateStore';
import Immutable from 'immutable';

class WorkoutListContainer extends React.Component {
    static getStores() {
        return [
            WorkoutTemplateStore
        ];
    }

    static calculateState() {
        return Immutable.OrderedMap();
    }
};

export default Container.create(WorkoutListContainer);