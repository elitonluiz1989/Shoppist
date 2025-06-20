package com.elitonluiz1989.infrastructure.repositories

import com.elitonluiz1989.domain.items.Item
import com.elitonluiz1989.domain.items.ItemRepository
import com.elitonluiz1989.infrastructure.daos.ItemsDao
import com.elitonluiz1989.infrastructure.entities.ItemEntity
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.map
import javax.inject.Inject

class ItemRepositoryImpl @Inject constructor(private val dao: ItemsDao): ItemRepository {
    override fun getAll(): Flow<List<Item>> {
        return dao.getAll().map { list -> list.map { it.toItem() } }
    }

    override suspend fun upsert(model: Item) {
        return dao.upsert(ItemEntity.fromItem(model))
    }

    override suspend fun delete(model: Item) {
        return dao.delete(ItemEntity.fromItem(model))
    }
}